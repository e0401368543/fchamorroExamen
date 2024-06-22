using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fchamorroExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen()
    {
		InitializeComponent();
        
    }

    public Resumen(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: " + usuario;
        

    }

    public void datosEstudiante(string nombre, string apellido, string edad
        //, Date fecha
        ,string ciudad
        ,string pais, double montoinicial, double pagomensual
        ) { 
        lblNombreR.Text = nombre;
        lblApellido.Text = apellido;    
        lblEdad.Text = edad;
       // lblFecha.Text = Convert.ToString(fecha);
        lblCiudad.Text = ciudad;    
        lblPais.Text = pais;
        lblMontoInicial.Text = Convert.ToString(montoinicial);
        lblMensual.Text= Convert.ToString(pagomensual);
        lbltotal.Text = Convert.ToString(montoinicial+ pagomensual*4);


        
    
    }


}