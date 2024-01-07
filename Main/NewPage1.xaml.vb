<Assembly: Microsoft.Maui.Controls.Xaml.XamlResourceId("GPT_ON.NewPage1.xaml", "NewPage1.xaml", GetType(GPT_ON.NewPage1))>
Namespace GPT_ON
    Public Class NewPage1
        Inherits Microsoft.Maui.Controls.ContentPage

        Private lblWelcome As Microsoft.Maui.Controls.Label

        Public Sub New()
            Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(Me, GetType(NewPage1))
            lblWelcome = Microsoft.Maui.Controls.NameScopeExtensions.FindByName(Of Microsoft.Maui.Controls.Label)(Me, "lblWelcome")
        End Sub

    End Class
End Namespace
