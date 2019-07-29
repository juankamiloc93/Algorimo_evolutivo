using System;
using System.Text;

public class Cadena
{
    private StringBuilder cadena;
    private Random aleatorio = new Random();

    public Cadena(int longitud)
	{
        this.cadena = new StringBuilder("");
        for (int i = 0; i < longitud; i++)
        {            
            this.cadena.Append(this.CarcaterAleatorio());            
        }
    }

    public Cadena(string cadena)
    {
        this.cadena = new StringBuilder(cadena);
    }
    
    private char CarcaterAleatorio()
    {
        char caracter = (char) this.aleatorio.Next(64, 90);
        if (caracter == '@')
        {
            caracter = ' ';
        }
        return caracter;
    }

    public string getCadena()
    {
        return this.cadena.ToString();
    }

    public int getPuntuacion(string objetivo)
    {
        int correctos = 0;
        for (int i=0; i<this.cadena.Length; i++)
        {
            if (this.cadena[i] == objetivo[i])
            {
                correctos++;
            }
        }
        return correctos;
    }

    public void mutar()
    {
        for(int i=0; i<this.cadena.Length; i++)
        {
            bool mutado = false;
            int probabilidad = this.aleatorio.Next(1, 100);
            if (probabilidad <= 3)
            {
                while (!mutado)
                {
                    char caracter = this.CarcaterAleatorio();
                    if (this.cadena[i] != caracter)
                    {
                        this.cadena[i] = caracter;
                        mutado = true;
                    }
                }
            }               

        }             
    }
}
