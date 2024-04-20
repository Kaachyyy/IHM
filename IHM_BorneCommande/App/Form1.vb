
Imports System.Windows.Forms

Imports System.IO

Public Class Form1
    ' Déclaration de la liste de commandes
    Dim Commande As New List(Of String)()
    Private Sub ButtondCf_Click(sender As Object, e As EventArgs) Handles ButtondCf.Click
        AjouterProduitAuPanier(LabelChocoF.Text)

    End Sub

    ' Ajoute un produit au panier et à la liste de commandes
    Private Sub AjouterProduitAuPanier(nomProduit As String)
        Dim choix As DialogResult = MessageBox.Show("Add " & nomProduit & " to the cart?", "Confirmation", MessageBoxButtons.YesNo)
        If choix = DialogResult.Yes Then
            ' Ajouter le produit à la liste de commandes
            Commande.Add(nomProduit)
            MessageBox.Show(nomProduit & " was added to the cart.")
        End If
    End Sub
    ' Ajoute une boisson au panier et à la liste de commandes




    ' Affiche les détails de la commande actuelle
    'Affiche les détails de la commande actuelle


    Private Sub AfficherDetailsCommande()
        Dim details As String = vbCrLf
        If Commande.Count > 0 Then
            For Each produit As String In Commande
                details &= "- " & produit & vbCrLf
            Next
        Else
            details &= "No item in this order."
        End If
        NomItem.Text = details
    End Sub

    Private Sub ButnRetirer_Click(sender As Object, e As EventArgs) Handles ButnRetirer.Click
        ' Vérifiez d'abord si la liste n'est pas vide
        If Commande.Count > 0 Then
            ' Affichez une boîte de dialogue d'entrée demandant à l'utilisateur de saisir le nom de l'élément à retirer
            Dim elementARetirer As String = InputBox("Type the name of the item you want to remove:", "Remove an item")

            ' Vérifiez si l'élément saisi par l'utilisateur est présent dans la liste
            If Commande.Contains(elementARetirer) Then
                ' Si l'élément est trouvé, retirez-le de la liste
                Commande.Remove(elementARetirer)
                ' Actualisez l'affichage des détails de la commande
                AfficherDetailsCommande()
                ' Affichez un message pour informer l'utilisateur que l'élément a été retiré avec succès
                MessageBox.Show(elementARetirer & "' was removed from your order.", "Item removed")
            Else
                ' Si l'élément n'est pas trouvé dans la liste, affichez un message d'erreur
                MessageBox.Show(elementARetirer & "does not exist in this order.", "Item not found")
            End If
        Else
            ' Si la liste est vide, affichez un message indiquant que la liste est vide
            MessageBox.Show("Command is empty .", "Empty command")
        End If
    End Sub




    Private Sub ButtonCart_Click(sender As Object, e As EventArgs) Handles ButtonCart.Click
        If Commande.Count = 0 Then
            AfficherPage("Cart")
            PanelErrorCart.Visible = True
            PanelItem.Visible = False
            PanelErrorCart.Location = New System.Drawing.Point(100, 62)
            ConfirmButton.Visible = False
            ButnRetirer.Visible = False


        End If
        If Commande.Count > 0 Then
            AfficherPage("Cart")
            PanelItem.Visible = True
            PanelErrorCart.Visible = False
            ConfirmButton.Visible = True
            ButnRetirer.Visible = True

            AfficherDetailsCommande()
        End If


    End Sub

    Private Sub ButtonDonuts_Click(sender As Object, e As EventArgs) Handles ButtonDonuts.Click
        AfficherPage("Donuts")
    End Sub

    Private Sub ButtonDrinks_Click(sender As Object, e As EventArgs) Handles ButtonDrinks.Click
        AfficherPage("Drinks")

    End Sub

    Private Sub ButtonSBall_Click(sender As Object, e As EventArgs) Handles ButtonSBall.Click
        AjouterProduitAuPanier(LabelSnowBall.Text)
    End Sub

    Private Sub ButtonVDonut_Click(sender As Object, e As EventArgs) Handles ButtonVDonut.Click
        AjouterProduitAuPanier(LabelValentine.Text)
    End Sub

    Private Sub ButtonChocoDonut_Click(sender As Object, e As EventArgs) Handles ButtonChocoDonut.Click
        AjouterProduitAuPanier(LabelChocolate.Text)
    End Sub

    Private Sub ButtonChocoVanilla_Click(sender As Object, e As EventArgs) Handles ButtonChocoVanilla.Click
        AjouterProduitAuPanier(LabelChocoVa.Text)
    End Sub

    Private Sub ButtonHalfDonut_Click(sender As Object, e As EventArgs) Handles ButtonHalfDonut.Click
        AjouterProduitAuPanier(LabelHalf.Text)
    End Sub

    ' Gestion des boissons



    Private Sub AfficherPage(page As String)
        ' Masquer toutes les pages
        PanelBtnCart.Visible = False
        PanelBtnDrinks.Visible = False
        PanelBtnDonuts.Visible = False
        PanelDonuts.Visible = False
        PanelDrinks.Visible = False
        PanelCart.Visible = False

        ' Afficher la page correspondante
        Select Case page
            Case "Cart"
                PanelBtnCart.Visible = True
                PanelCart.Visible = True
                PanelCart.BringToFront()
                PanelCart.Dock = DockStyle.Fill

            Case "Donuts"
                PanelBtnDonuts.Visible = True
                PanelDonuts.Visible = True
                PanelDonuts.BringToFront()
                PanelDonuts.Dock = DockStyle.Fill
            Case "Drinks"
                PanelBtnDrinks.Visible = True
                PanelDrinks.Visible = True
                PanelDrinks.BringToFront()
                PanelDrinks.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Masquer toutes les pages au chargement du formulaire
        PanelBtnCart.Visible = False
        PanelBtnDrinks.Visible = False
        AfficherPage("Donut")

    End Sub
    Private Sub ButtonHotCofee_Click(sender As Object, e As EventArgs) Handles ButtonHotCofee.Click
        AjouterProduitAuPanier(LabelHotCofee.Text)
    End Sub

    Private Sub ButtonIcedCofee_Click(sender As Object, e As EventArgs) Handles ButtonIcedCofee.Click
        AjouterProduitAuPanier(LabelIcedCofee.Text)

    End Sub

    Private Sub ButtonColdBrew_Click(sender As Object, e As EventArgs) Handles ButtonColdBrew.Click
        AjouterProduitAuPanier(LabelColdBrew.Text)

    End Sub

    Private Sub ButtonEspresso_Click(sender As Object, e As EventArgs) Handles ButtonEspresso.Click
        AjouterProduitAuPanier(LabelEspresso.Text)

    End Sub

    Private Sub ButtonRefresher_Click(sender As Object, e As EventArgs) Handles ButtonRefresher.Click
        AjouterProduitAuPanier(LabelRefresher.Text)

    End Sub

    Private Sub ButtonGreenTea_Click(sender As Object, e As EventArgs) Handles ButtonGreenTea.Click
        AjouterProduitAuPanier(LabelGreenTea.Text)

    End Sub

    Private Sub EnregistrerCommandeDansFichier()
        Try
            ' Créer un nouveau fichier texte ou écraser le fichier existant
            Using writer As New StreamWriter("C:\Users\kachy\Documents\BUT 1\App\Commandes\cmd.txt")
                For Each produit As String In Commande
                    writer.WriteLine(produit)
                Next
            End Using
            MessageBox.Show("Your order has been registered")
        Catch ex As Exception
            MessageBox.Show("Error", "File Error")
        End Try
    End Sub

    Private Sub ButtonConfirm_click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        EnregistrerCommandeDansFichier()
        End
    End Sub


End Class
