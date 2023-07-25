namespace Expresiones;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// <Company>INDEL</Company>
    /// <CreationDate>12/07/2023</CreationDate>
    /// <LastDateModification>24/07/2023</LastDateModification>
    /// <ModifyDescriptions>
    /// Se creo un metodo el cual por un click empieza a calcular por medio de jerarquía calcula una
    /// suma, la eleva al cuadrado y luego lo divide entre dos dando asi, el resultado en un apartado de texto.
    /// En caso de no tener caracteres en las entradas, el programa lanza una advertencia.
    /// </ModifyDescriptions>
    /// </summary>
    
    private void BtnOperate_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(EntryA.Text)
         && !string.IsNullOrEmpty(EntryB.Text))
        {
            double Dato1, Dato2, Resultado;

            Dato1 = Convert.ToDouble(EntryA.Text);
            Dato2 = Convert.ToDouble(EntryB.Text);

            Resultado = Math.Pow((Dato1 + Dato2),2)/2;

            Respuesta.Text = Convert.ToString(Resultado);

        }
        else
        {
            DisplayAlert("Error", "Intrduce todos los numeros", "OK");
        }
    }
}

