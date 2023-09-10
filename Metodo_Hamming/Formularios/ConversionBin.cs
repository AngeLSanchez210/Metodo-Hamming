using System.Windows.Forms;
using System.Xml.Serialization;
using Metodo_Hamming.Logica;

namespace Metodo_Hamming
{
    public partial class ConversionBin : Form
    {
        // Declara una variable global de instancia para almacenar la selección actual.
        public string seleccion = "";

        // Declara un objeto de la clase 'Validaciones'.
        Validaciones Validar;

        // Inicializa un nuevo objeto de la clase 'Conversiones'.
        Conversiones Convertir = new();

        public ConversionBin()
        {
            InitializeComponent();

            // Inicializa el objeto 'Validar' pasando tres controles como argumentos.
            Validar = new(errorConversion, txtDatoIngresado, cbTipoDato);
        }

        // Manejador del evento de presiionar una tecla en el control 'txtDatoIngresado'.
        private void txtDatoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limpia los mensajes de error de todos los controles en el formulario.
            foreach (Control c in Controls)
            {
                errorConversion.SetError(c, "");
            }

            // Basado en la selección actual, valida la entrada de teclado.
            switch (seleccion)
            {
                case "Entero sin signo":
                    // Valida si la entrada es un número sin signo.
                    Validar.NumerosSinSigno(e);
                    break;
                case "Entero con signo (Complemento 1)":
                    // Valida si la entrada es un número con signo.
                    Validar.NumerosConSigno(e, txtDatoIngresado);
                    break;
                case "Entero con signo (Bit mas representativo)":
                    // Valida si la entrada es un número con signo.
                    Validar.NumerosConSigno(e, txtDatoIngresado);
                    break;
                case "Flotante (Estandar IEEE754 para 16 bits)":
                    // Valida si la entrada es un número flotante.
                    Validar.NumerosFlotantes(e, txtDatoIngresado.Text);
                    break;
                case "Caracter (Codificacion ASCIIZ)":
                    // Valida si la entrada es un carácter.
                    Validar.Texto(e);
                    break;
                case "Cadena de caracteres (Codificacion ASCIIZ)":
                    // Valida si la entrada es una cadena de caracteres.
                    Validar.Texto(e);
                    break;
                default:
                    // Si no se seleccionó una opción válida, muestra un mensaje de error y detiene el procesamiento del evento.
                    errorConversion.SetError(cbTipoDato, "Seleccione el tipo de dato");
                    e.Handled = true;  // Detiene el procesamiento del evento.
                    break;
            }
        }

        // Manejador del evento que se dispara cuando cambia el ítem seleccionado en el control desplegable 'cbTipoDato'.
        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reinicia el texto del control 'txtDatoIngresado'.
            txtDatoIngresado.Text = "";

            // Actualiza la variable 'seleccion' con el valor seleccionado en el control desplegable.
            seleccion = cbTipoDato.Text;

            // Establece un valor por defecto en 'lblResultado'.
            lblResultado.Text = "0000 0000 0000 0000";

            // Limpia los mensajes de error de todos los controles en el formulario.
            foreach (Control c in Controls)
            {
                errorConversion.SetError(c, "");
            }
        }


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Verifica si el texto ingresado no está vacío.
            if (txtDatoIngresado.Text != "")
            {
                // Dependiendo del valor de 'seleccion', se ejecutará un caso diferente.
                switch (seleccion)
                {
                    // Caso para números enteros sin signo.
                    case "Entero sin signo":
                        // Realiza la conversión a un entero sin signo.
                        string resultado = Convertir.EnterosSinSigno(txtDatoIngresado.Text);

                        // Verifica si el resultado de la conversión está vacío.
                        if (resultado == "")
                        {
                            // Si está vacío, muestra un mensaje de error.
                            errorConversion.SetError(txtDatoIngresado, "El dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            // Si la conversión es exitosa, muestra el resultado.
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Caso para números enteros con signo usando complemento 1.
                    case "Entero con signo (Complemento 1)":
                        // Realiza la conversión a un entero con signo.
                        resultado = Convertir.EnterosConSigno(txtDatoIngresado.Text, cbTipoDato.Text);

                        // (Las siguientes líneas son similares a las del caso anterior, por lo que no se repiten los comentarios).
                        if (resultado == "")
                        {
                            errorConversion.SetError(txtDatoIngresado, "El dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Caso para números enteros con signo usando el bit más significativo.
                    case "Entero con signo (Bit mas representativo)":
                        resultado = Convertir.EnterosConSigno(txtDatoIngresado.Text, cbTipoDato.Text);

                        if (resultado == "")
                        {
                            errorConversion.SetError(txtDatoIngresado, "El dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Caso para números flotantes según el estándar IEEE754 para 16 bits.
                    case "Flotante (Estandar IEEE754 para 16 bits)":
                        resultado = Convertir.ConvertirAHalfPrecision(float.Parse(txtDatoIngresado.Text));

                        if (resultado == "")
                        {
                            errorConversion.SetError(txtDatoIngresado, "El dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Caso para caracteres usando la codificación ASCIIZ.
                    case "Caracter (Codificacion ASCIIZ)":
                        resultado = Convertir.CaracterABinario(txtDatoIngresado.Text);

                        if (resultado == "")
                        {
                            errorConversion.SetError(txtDatoIngresado, "Ingrese solo un caracter");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Caso para cadenas de caracteres usando la codificación ASCIIZ.
                    case "Cadena de caracteres (Codificacion ASCIIZ)":
                        resultado = Convertir.CadenaABinario(txtDatoIngresado.Text);

                        //Si la dimension de la cadena es de un caracter se manda un error
                        if (txtDatoIngresado.Text.Length <= 1)
                        {
                            errorConversion.SetError(txtDatoIngresado, "Esta opcion es para una cadena, si desea representar un caracter seleccione la opcion Caracter");
                        }
                        else if (resultado == "")
                        {
                            errorConversion.SetError(txtDatoIngresado, "La cadena es de una dimension que no puede ser representada en 16 bits (Dos caracter)");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    // Si 'seleccion' no corresponde a ninguno de los casos anteriores, muestra un mensaje de error.
                    default:
                        errorConversion.SetError(cbTipoDato, "Seleccione el tipo de dato");
                        break;
                }
            }
            else
            {
                // Si no hay dato ingresado, muestra un mensaje de error.
                errorConversion.SetError(txtDatoIngresado, "Ingrese el dato a convertir");
            }
        }
    }
}