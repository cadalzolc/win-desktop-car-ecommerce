Public Class Session

    Private Shared PVT_CurrentUser As User = New User()

    Public Shared Property CurrentUser() As User
        Get
            Return PVT_CurrentUser
        End Get
        Set(ByVal value As User)
            PVT_CurrentUser = value
        End Set
    End Property

End Class
