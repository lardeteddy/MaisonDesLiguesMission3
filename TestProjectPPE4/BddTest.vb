Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BaseDeDonnees



'''<summary>
'''Classe de test pour BddTest, destinée à contenir tous
'''les tests unitaires BddTest
'''</summary>
<TestClass()> _
Public Class BddTest


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
    '''Test pour ObtenirDonnesOracle
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub ObtenirDonnesOracleTest()
        Dim param0 As PrivateObject = Nothing ' TODO: initialisez à une valeur appropriée
        Dim target As Bdd_Accessor = New Bdd_Accessor(param0) ' TODO: initialisez à une valeur appropriée
        Dim expected As DataTable = Nothing ' TODO: initialisez à une valeur appropriée
        Dim actual As DataTable
        actual = target.ObtenirDonnesOracle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour MajVacation
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub MajVacationTest()
        Dim param0 As PrivateObject = Nothing ' TODO: initialisez à une valeur appropriée
        Dim target As Bdd_Accessor = New Bdd_Accessor(param0) ' TODO: initialisez à une valeur appropriée
        Dim uneCle As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim unId As Integer = 0 ' TODO: initialisez à une valeur appropriée
        target.MajVacation(uneCle, unId)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub
End Class
