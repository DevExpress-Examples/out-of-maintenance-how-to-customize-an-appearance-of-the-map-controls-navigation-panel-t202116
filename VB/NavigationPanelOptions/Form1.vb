Imports System
Imports System.Windows.Forms

Namespace NavigationPanelOptions
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#NavigationPanelOptions"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            mapControl1.NavigationPanelOptions.XCoordinatePattern = "{CP}{D}.{M}.{S:4}"
            mapControl1.NavigationPanelOptions.YCoordinatePattern = "{CP}{D}.{M}.{S:4}"
            mapControl1.NavigationPanelOptions.ShowKilometersScale = False
            mapControl1.NavigationPanelOptions.ShowMilesScale = False
            mapControl1.NavigationPanelOptions.ShowScrollButtons = False
        End Sub
        #End Region ' #NavigationPanelOptions
    End Class
End Namespace
