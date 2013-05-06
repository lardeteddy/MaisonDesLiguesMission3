Imports System.Windows.Forms

Imports BaseDeDonnees

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports MaisonDesLigues



'''<summary>
'''Classe de test pour UtilitaireTest, destinée à contenir tous
'''les tests unitaires UtilitaireTest
'''</summary>
<TestClass()> _
Public Class UtilitaireTest


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
    '''Test pour GetRandom
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub GetRandomTest()
        Dim expected As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim actual As String
        actual = Utilitaire_Accessor.GetRandom
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour EnvoiMail
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub EnvoiMailTest()
        Dim mail As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim NomPrenom As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim Cléwifi As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Utilitaire_Accessor.EnvoiMail(mail, NomPrenom, Cléwifi)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour RemplirComboBox
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub RemplirComboBoxTest()
        Dim UneConnexion As Bdd_Accessor = Nothing ' TODO: initialisez à une valeur appropriée
        Dim UneCombo As ComboBox = Nothing ' TODO: initialisez à une valeur appropriée
        Utilitaire_Accessor.RemplirComboBox(UneConnexion, UneCombo)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour RemplirTextBox
    '''</summary>
    <TestMethod(), _
     DeploymentItem("MaisonDesLiguesMission3.exe")> _
    Public Sub RemplirTextBoxTest()
        Dim UneConnexion As Bdd_Accessor = Nothing ' TODO: initialisez à une valeur appropriée
        Dim maTextBox As TextBox = Nothing ' TODO: initialisez à une valeur appropriée
        Dim monChamp As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim idParticipant As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Utilitaire_Accessor.RemplirTextBox(UneConnexion, maTextBox, monChamp, idParticipant)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub
End Class
