Imports System.Drawing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports MaisonDesLigues



'''<summary>
'''Classe de test pour QRCODETest, destinée à contenir tous
'''les tests unitaires QRCODETest
'''</summary>
<TestClass()> _
Public Class QRCODETest


    Private testContextInstance As TestContext

    '''<summary>
    '''Obtient ou définit le contexte de test qui fournit
    '''des informations sur la série de tests active ainsi que ses fonctionnalités.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Attributs de tests supplémentaires"
    '
    'Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
    '
    'Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Test pour Constructeur QRCODE
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub QRCODEConstructorTest()
        Dim target As QRCODE_Accessor = New QRCODE_Accessor()
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour QRGen
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub QRGenTest()
        Dim target As QRCODE_Accessor = New QRCODE_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim input As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim qrlevel As Integer = 0 ' TODO: initialisez à une valeur appropriée
        Dim expected As Image = Nothing ' TODO: initialisez à une valeur appropriée
        Dim actual As Image
        actual = target.QRGen(input, qrlevel)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub
End Class
