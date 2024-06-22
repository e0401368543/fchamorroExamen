namespace fchamorroExamen.Views;

public partial class Login : ContentPage
{

    string[,] matrixUsers = new string[2, 2]
       {
            { "estudiante", "moviles" },
            {"uisrael", "2024"  }

       };
    public Login()
	{
		InitializeComponent();       
    }
    string user = "";
    string pasword = "";
   
    public Login(string usuario, string contraseña)
    {
        InitializeComponent();
        user = usuario;
        pasword = contraseña;
    }

    private void btnIngreso_Clicked(object sender, EventArgs e)
    {
        int i = 0;

        if (string.IsNullOrEmpty(txtUsaurio.Text) || string.IsNullOrEmpty(txtContraseña.Text))
        {
            DisplayAlert("Alerta", "Ingrese el usuario/contraseña", "Cancel");
            return;
        }


        while (i < matrixUsers.GetLength(0))
        {


             DisplayAlert("Alerta", "Usuario no existe"+ matrixUsers[i,0]+" :pos: " +i, "Ok");


            if (txtUsaurio.Text != matrixUsers[i,0])
                i += 1;

        }

        if (i == matrixUsers.GetLength(0))
        {
            DisplayAlert("Alerta", "Dato Incorrecto", "Ok");
            return;
        }

        if (txtUsaurio.Text == matrixUsers[i,0])
        {
            if (txtContraseña.Text == matrixUsers[i, 1])
            {
                Navigation.PushAsync(new Registro(txtUsaurio.Text));

            }
            else
                DisplayAlert("Alerta", "Dato Incorrecto", "Ok");

        }
        else
        {


            if (user == txtUsaurio.Text && pasword == txtUsaurio.Text)
            {
                Navigation.PushAsync(new Registro(txtUsaurio.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Dato Incorrecto", "Ok");
            }
        }

    }

    private void btnIngreso_Clicked_1(object sender, EventArgs e)
    {
        int i = 0;

        if (string.IsNullOrEmpty(txtUsaurio.Text) || string.IsNullOrEmpty(txtContraseña.Text))
        {
            DisplayAlert("Alerta", "Ingrese el usuario/contraseña", "Cancel");
            return;
        }


        while (i <2 ) //matrixUsers.GetLength(0)
        {


            DisplayAlert("Alerta", "Usuario no existe" + matrixUsers[i, 0] + " :pos: " + i, "Ok");


            if (txtUsaurio.Text != matrixUsers[i, 0])
                i += 1;
            else { 
                break;
            }

        }

        if (i == matrixUsers.GetLength(0))
        {
            DisplayAlert("Alerta", "Dato Incorrecto", "Ok");
            return;
        }

        if (txtUsaurio.Text == matrixUsers[i, 0])
        {
            if (txtContraseña.Text == matrixUsers[i, 1])
            {
                Navigation.PushAsync(new Registro(txtUsaurio.Text));

            }
            else
                DisplayAlert("Alerta", "Dato Incorrecto", "Ok");

        }
        else
        {


            if (user == txtUsaurio.Text && pasword == txtUsaurio.Text)
            {
                Navigation.PushAsync(new Registro(txtUsaurio.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Dato Incorrecto", "Ok");
            }
        }
    }
}