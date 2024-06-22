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
        //, Date fecha, string ciudad
        //,string pais, double montoinicial, double pagomensual, double pagototal
        ) { 
        lblNombreR.Text = nombre;
    
    }


}