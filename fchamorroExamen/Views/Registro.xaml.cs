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
        resultado = (monto - montoIngresado)/4+ 1500*0.04;
        txtPagoMensual.Text =Convert.ToString(resultado);

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string ciudad= pkCiudad.SelectedItem.ToString();
        string pais = pkPais.SelectedItem.ToString();


        Resumen resumen = new Resumen(usuario);
        resumen.datosEstudiante(txtNombre.Text,txtApellido.Text,txtEdad.Text, ciudad, pais,Convert.ToDouble(txtMontoInicial.Text), Convert.ToDouble(txtPagoMensual.Text));
        Navigation.PushAsync(resumen);


    }
}