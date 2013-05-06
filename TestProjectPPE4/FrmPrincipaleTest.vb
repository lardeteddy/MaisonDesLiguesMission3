Imports System.Drawing.Printing

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports MaisonDesLigues



'''<summary>
'''Classe de test pour FrmPrincipaleTest, destinée à contenir tous
'''les tests unitaires FrmPrincipaleTest
'''</summary>
<TestClass()> _
Public Class FrmPrincipaleTest


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
    '''Test pour Constructeur FrmPrincipale
    '''</summary>
    <TestMethod()> _
    Public Sub FrmPrincipaleConstructorTest()
        Dim target As FrmPrincipale = New FrmPrincipale()
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour Btn_Imprimer_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub Btn_Imprimer_ClickTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.Btn_Imprimer_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour Btn_enregArrivé_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub Btn_enregArrivé_ClickTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.Btn_enregArrivé_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour FrmPrincipale_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub FrmPrincipale_LoadTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.FrmPrincipale_Load(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour cmb_Participant_SelectionChangeCommitted
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub cmb_Participant_SelectionChangeCommittedTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.cmb_Participant_SelectionChangeCommitted(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour radioButton1_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub radioButton1_CheckedChangedTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.radioButton1_CheckedChanged(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour uneimpression_PrintPage
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub uneimpression_PrintPageTest()
        Dim target As FrmPrincipale_Accessor = New FrmPrincipale_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As PrintPageEventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.uneimpression_PrintPage(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub
End Class
