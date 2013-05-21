using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;



namespace MvcApplication2.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit avoir au minimum {2} caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau Mot de passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer nouveau mot de pass")]
        [Compare("NewPassword", ErrorMessage = "Le nouveau mot de passe ne correspond pas la confirmation !")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "Matricule :")]
        public string Matricule { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe :")]
        public string PassWord { get; set; }

        [Display(Name = "Se souvenir de moi ?")]
        public bool RememberMe { get; set; }
    }

    /*    public class RegisterModel
        {
            [Required]
            [Display(Name = "Nom Utilisateur :")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email :")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "Le {0} doit avoir au minimum {2} caractères.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Mot de passe :")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmer mot de passe :")]
            [Compare("Password", ErrorMessage = "Le mot de passe ne correspond pas la confirmation !")]
            public string ConfirmPassword { get; set; }*/


    //public class AddUserModel
    //{
    //    [Required]
    //    [Display(Name = "Matricule :")]
    //    public string Matricule { get; set; }

    //    [Required]
    //    [Display(Name = "Nom :")]
    //    public string Nom_User { get; set; }

    //    [Required]
    //    [StringLength(100, ErrorMessage = "Le {0} doit avoir au minimum {2} caractères.", MinimumLength = 6)]
    //    [DataType(DataType.Password)]
    //    [Display(Name = "Mot de passe :")]
    //    public string passWord { get; set; }

    //    [DataType(DataType.Password)]
    //    [Display(Name = "Confirmer mot de passe :")]
    //    [Compare("Password", ErrorMessage = "Le mot de passe ne correspond pas la confirmation !")]
    //    public string ConfirmPassword { get; set; }

    //    [Required]
    //    [Display(Name = "Type :")]
    //    public string Type_User { get; set; }

    //    [Required]
    //    [Display(Name = "ID_UF :")]
    //    public string ID_UF { get; set; }

        //public int Insert(string Matricule, string Nom_User, string passWord, string Type_User, string ID_UF)
        //{
        //    SqlConnection cn = new SqlConnection(@"Data Source = SWEET-DE396641E \ SQLEXPRESS; User Id = adminUser; Password = adminUser; Initial Catalog = Gamme");
        //    cn.Open();


        //    string sqlquery = ("Insert Into Users(Matricule, Nom_User,PassWord, Type_User, ID_UF )Values(@Matricule, @Nom_User, @passWord, @Type_User, @ID_UF)");
        //    SqlCommand cmd = new SqlCommand(sqlquery, cn);

            
        //    cmd.Parameters.AddWithValue("@Matricule", this.Matricule);
        //    cmd.Parameters.AddWithValue("@Nom_User", this.Nom_User);
        //    cmd.Parameters.AddWithValue("@passWord", this.passWord);
        //    cmd.Parameters.AddWithValue("@Type_User", this.Type_User);
        //    cmd.Parameters.AddWithValue("@ID_UF", this.ID_UF);
        //    return cmd.ExecuteNonQuery();
        //}

        
    //}



    //public class AddPosteModel
    //{
    //    [Required]
    //    [Display(Name = "ID_Poste :")]
    //    public string ID_Poste { get; set; }

    //    [Required]
    //    [Display(Name = "nom_Poste:")]
    //    public string nom_Poste { get; set; }

    //    [Required]
    //    [Display(Name = "Application :")]
    //    public string Application { get; set; }

    //    [Required]
    //    [Display(Name = "In_Po :")]
    //    public string In_Po { get; set; }

    //    [Required]
    //    [Display(Name = "Out_Po :")]
    //    public string Out_Po { get; set; }

    //    [Required]
    //    [Display(Name = "Etat :")]
    //    public string Etat { get; set; }

    //    [Required]
    //    [Display(Name = "ID_Ligne :")]
    //    public string ID_Ligne { get; set; }

    //    [Required]
    //    [Display(Name = "Mouvement :")]
    //    public string Mouvement { get; set; }

    //    public int InsertPoste(string ID_Poste, string nom_Poste, string Application, string In_Po, string Out_Po, string Etat, string ID_Ligne, string Mouvement)
    //    {
    //        SqlConnection cn = new SqlConnection(@"Data Source = SWEET-DE396641E \ SQLEXPRESS; User Id = adminUser; Password = adminUser; Initial Catalog = Gamme");
    //        cn.Open();


    //        string sqlquery = ("Insert Into Users(ID_Poste, nom_Poste, Application, In_Po, Out_Po, Etat, ID_Ligne, Mouvement)Values(@ID_Poste, @nom_Poste, @Application, @In_P, @Out_P, @Etat, @ID_Ligne, @Mouvement)");
    //        SqlCommand cmd = new SqlCommand(sqlquery, cn);

            // SqlCommand cmd = new SqlCommand("Insert Into Users(Matricule, Nom_User,PassWord, Type_User )Values('" + Matricule + "','" + Nom_User + "','" + passWord + "','" + Type_User + "')", cn);
            //SqlCommand cmd = new SqlCommand("Insert Into Users(Matricule, Nom_User,PassWord, Type_User )Values('user2','anouar','anouar','Admin')", cn);
            //cmd.Parameters.AddWithValue("@ID_Poste", TextBox1.Text);

        //    cmd.Parameters.Add(new SqlParameter("@ID_Poste", this.ID_Poste));
        //    cmd.Parameters.Add(new SqlParameter("@nom_Poste", this.nom_Poste));
        //    cmd.Parameters.Add(new SqlParameter("@Application", this.Application));
        //    cmd.Parameters.Add(new SqlParameter("@In_Po", this.In_Po));
        //    cmd.Parameters.Add(new SqlParameter("@Out_Po", this.Out_Po));
        //    cmd.Parameters.Add(new SqlParameter("@Etat", this.Etat));
        //    cmd.Parameters.Add(new SqlParameter("@ID_Ligne", this.ID_Ligne));
        //    cmd.Parameters.Add(new SqlParameter("@Mouvement", this.Mouvement));
        //    return cmd.ExecuteNonQuery();
        //}
    //}
}