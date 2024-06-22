namespace fchamorroExamen.Views;

public partial class Registro : ContentPage
{
    double monto = 1500;
    double montoIngresado = 0;
    double resultado = 0;
    string usuario;
	public Registro()
	{
		InitializeComponent();
	}
    public Registro(string nombre)
    {
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: " + nombre;
        usuario=nombre;

    }

    private void btnCalcularPagoMenual_Clicked(object sender, EventArgs e)
    {

        montoIngresado = Convert.ToDouble(txtMontoInicial.Text);
        resultado = (monto - montoIngresado) * 1.04;
        txtPagoMensual.Text =Convert.ToString(resultado);

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Resumen resumen = new Resumen(usuario);
        resumen.datosEstudiante(txtNombre.Text,txtApellido.Text,txtEdad.Text);
        Navigation.PushAsync(resumen);


    }
}