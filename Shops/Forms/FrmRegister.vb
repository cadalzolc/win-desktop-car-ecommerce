Public Class FrmRegister

#Region " Load Data "

    Sub LoadCombo()
        Dim Genders = DB.ToData("SELECT * FROM Genders")
        Dim Types = DB.ToData("SELECT * FROM Payments_Card_Type")

        Filler.Load(CboGender, Genders, "Name", "Name")
        Filler.Load(CboCard_Type, Types, "Name", "ID")
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        dtpExpiry.MinDate = Date.Now
        dtpExpiry.MaxDate = Date.Now.AddYears(5)
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        If IsComplete().Equals(False) Then Exit Sub

        If Save().Equals(False) Then Exit Sub

        Toast.Message("Your member registration is successful! Please login using your credentials.")

        DialogResult = DialogResult.OK

        Close()
    End Sub

#End Region

#Region " Validation "

    Function IsComplete() As Boolean
        Dim Rows = Util.Controls(Me).OrderBy(Function(r) r.Control_Index).AsEnumerable()
        For Each Row In Rows
            Dim Ctl = Row.Control_Type
            Select Case TypeName(Ctl)
                Case "TextBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please input {0}", Ctl.Name.Replace("Txt", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
                Case "ComboBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please select {0}", Ctl.Name.Replace("Cbo", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function

#End Region

#Region " Save "

    Function Save() As Boolean
        Using Con = DB.Connection
            Dim Trans = Con.BeginTransaction()
            Try

                Dim ID As Integer = 0

                Using CmdCustomer = DB.Command("INSERT INTO Customers (First_Name, Middle_Name, Last_Name, Gender, Email, Contact_No) VALUES (@First_Name, @Middle_Name, @Last_Name, @Gender, @Email, @Contact_No)", Con, Trans)

                    CmdCustomer.Parameters.AddWithValue("@First_Name", TxtFirst_Name.Text)
                    CmdCustomer.Parameters.AddWithValue("@Middle_Name", TxtMiddle_Name.Text)
                    CmdCustomer.Parameters.AddWithValue("@Last_Name", TxtLast_Name.Text)
                    CmdCustomer.Parameters.AddWithValue("@Gender", CboGender.SelectedValue)
                    CmdCustomer.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    CmdCustomer.Parameters.AddWithValue("@Contact_No", TxtContact_No.Text)
                    CmdCustomer.ExecuteNonQuery()

                    CmdCustomer.CommandText = "SELECT @@Identity"

                    ID = CmdCustomer.ExecuteScalar()
                End Using

                If ID.Equals(0) Then
                    Trans.Rollback()
                    Toast.Error("Something went wrong in saving member info")
                    Return False
                End If

                Using CmdAddress = DB.Command("INSERT INTO Customers_Shipment (Customer_ID, Address, City, State, Country, Zip_Code) VALUES(@Customer_ID, @Address, @City, @State, @Country, @Zip_Code)", Con, Trans)
                    CmdAddress.Parameters.AddWithValue("@Customer_ID", ID)
                    CmdAddress.Parameters.AddWithValue("@Address", TxtAddress.Text)
                    CmdAddress.Parameters.AddWithValue("@City", TxtCity.Text)
                    CmdAddress.Parameters.AddWithValue("@State", TxtProvince.Text)
                    CmdAddress.Parameters.AddWithValue("@Country", TxtCountry.Text)
                    CmdAddress.Parameters.AddWithValue("@Zip_Code", TxtZip_Code.Text)
                    CmdAddress.ExecuteNonQuery()
                End Using

                Using CmdCard = DB.Command("INSERT INTO Customers_Payments_Method (Customer_ID, Card_Type_ID, Name, Card_No, Card_Pin, Card_Expiry) VALUES(@Customer_ID, @Card_Type_ID, @Name, @Card_No, @Card_Pin, @Card_Expiry)", Con, Trans)
                    CmdCard.Parameters.AddWithValue("@Customer_ID", ID)
                    CmdCard.Parameters.AddWithValue("@Card_Type_ID", CboCard_Type.SelectedValue)
                    CmdCard.Parameters.AddWithValue("@Name", TxtAlias.Text)
                    CmdCard.Parameters.AddWithValue("@Card_No", TxtCard_No.Text)
                    CmdCard.Parameters.AddWithValue("@Card_Pin", TxtCard_Pin.Text)
                    CmdCard.Parameters.AddWithValue("@Card_Expiry", dtpExpiry.Value.ToString("yyyy-MM-dd"))
                    CmdCard.ExecuteNonQuery()
                End Using

                Using CmdUser = DB.Command("INSERT INTO Customers_Account (Customer_ID, [Username], [Password]) VALUES(@Customer_ID, @Username, @Password)", Con, Trans)
                    CmdUser.Parameters.AddWithValue("@Customer_ID", ID)
                    CmdUser.Parameters.AddWithValue("@Username", TxtUsername.Text)
                    CmdUser.Parameters.AddWithValue("@Password", TxtPassword.Text)
                    CmdUser.ExecuteNonQuery()
                End Using

                Trans.Commit()

                Return True
            Catch ex As Exception
                Trans.Rollback()
                Toast.Error(ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region

End Class