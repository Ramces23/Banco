using System;

namespace Banco
{
    class Program
    {
       struct Clientes
        {
           public  String Nombre;
           public  float Monto_actual;
            public float Retiro; 
        }

        Clientes[] Cliente = new Clientes[3];
        public void Client() 
        {    
            Cliente[Id_Cliente].Nombre = "Cliente " + Id_Cliente;
            Console.WriteLine("Bienvenido " + Cliente[Id_Cliente].Nombre);        
        }

        public void Depositar() {
            Transacciones++;
            Console.WriteLine("Introdusca el valor que va a depositar: ");
            Monto = int.Parse(Console.ReadLine());
            Cliente[Id_Cliente].Monto_actual += Monto;
            Monto_Banco += Monto;
            Transacciones--;
            Console.WriteLine("Transacciones{0} Monto {1} ", Transacciones, Monto);
            Deposito[Transacciones] = Monto;
            Transacciones++;
        }

        public void MosMonto_Actual() {
            Console.WriteLine("El Monto actual de su cuenta es: " + Cliente[Id_Cliente].Monto_actual);
        }

        public void MosMonto_Banco()
        {
            Console.WriteLine("El Monto actual en el banco es : " + Monto_Banco);
            float MD = 0;
           int  z = -1;

                do
                {
                    z++;
                    MD += Deposito[z];
                } while (Deposito[z] > 0);



            Console.WriteLine("Total depositado en el dia {0}", MD);
        }

        public void Retirar() {
            Transacciones++;
            do
            {
                Console.WriteLine("Digite el monto a retirar: ");
                Monto = int.Parse(Console.ReadLine());
                if (Monto > Cliente[Id_Cliente].Monto_actual)
                {
                    Console.WriteLine("El monto digitado es superior a el que en la cuenta, por favor digite otro monto ");
                }
            } while (Monto > Cliente[Id_Cliente].Monto_actual);
            Cliente[Id_Cliente].Monto_actual -= Monto;
            Monto_Banco -= Monto;
            Transacciones--;
            Console.WriteLine("Transacciones{0} Monto {1} ", Transacciones, Monto);
            Retiro[Transacciones] = Monto;
            Transacciones++;
        }

        public void Retiros() {
            int z = -1;
            int g = 0;
            do {
                z++;
                g = z + 1;
                Console.WriteLine("Retiro Nro-{0} {1}: ", g, Retiro[z]);
            } while (Retiro[z] > 0);        
        }

        public void Depositos()
        {
            int z = -1;
            int g = 0;
            do
            {
                z++;
                g = z + 1;
                Console.WriteLine("Deposito Nro-{0} {1}: ", g, Deposito[z]);
            } while (Deposito[z] > 0);
            float MD = 0;
            z = -1;
            do
            {
                z++;
                MD += Deposito[z];
            } while (Deposito[z] > 0);
            Console.WriteLine("Total depositado en el dia {0}", MD);

        }

        public void Constructor() {
            Cliente[Id_Cliente].Monto_actual = 1000;

        }
       private float[] MDC = new float[3];
        static float Monto_Banco = 3000;
        private float[] Retiro = new float[15];
        private float[] Deposito = new float[15];
        private float[] Monto_Dia_Total = new float[3];
        static int Id_Cliente;
        static int Transacciones = 0;
        static float Monto;
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Bienevenido a YourBank");
            Console.WriteLine("Especifique que cliente es usted: ");
            Id_Cliente = int.Parse(Console.ReadLine());
            Console.Clear();
            obj.Client();
            obj.Constructor();
            int y = 0;
            string j = "";
            Console.WriteLine("Presione enter para continuar ");
            Console.ReadKey();
            Console.Clear();

            do { 
            Console.WriteLine(" ______________________________________________\n");
            Console.WriteLine(" |               Menu Principal                |\n");
            Console.WriteLine(" |_____________________________________________|\n");
            Console.WriteLine(" | 1 - Depositar                               |\n");
            Console.WriteLine(" | 2 - Retirar                                 |\n");
            Console.WriteLine(" | 3 - Cambiar Usuario                         |\n ");
            Console.WriteLine(" | 4 - Mostrar                                 |\n ");
            Console.WriteLine(" | 5 - Cerrar programa                         |\n ");
            Console.WriteLine(" |_____________________________________________|\n");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (y) {

                case 1:
                    obj.Depositar();
                    break;
                case 2:
                    obj.Retirar();
                    break;
                case 3:
                        Console.WriteLine("Especifique que cliente es usted: ");
                        Id_Cliente = int.Parse(Console.ReadLine());
                        obj.Client();
                        obj.Constructor();



                        break;
                case 4:
                        
                    int q = 0; 
                        do { 
                    Console.WriteLine(" ______________________________________________\n");
                    Console.WriteLine(" |               Menu Principal                |\n");
                    Console.WriteLine(" |_____________________________________________|\n");
                    Console.WriteLine(" | 1 - Monto Actual                            |\n");
                    Console.WriteLine(" | 2 - Retiro                                  |\n");
                    Console.WriteLine(" | 3 - Depositos                               |\n ");
                    Console.WriteLine(" | 4 - Dinero en el Banco                      |\n ");
                    Console.WriteLine(" | 5 - Volver al menu principal                |\n ");
                    Console.WriteLine(" |_____________________________________________|\n");
                    q = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (q)
                    {
                        case 1:
                                    obj.MosMonto_Actual();
                                    Console.WriteLine("Presione enter para continuar ");
                                    Console.ReadKey();
                                    Console.Clear();

                                    break;
                        case 2:
                                    obj.Retiros();
                                    Console.WriteLine("Presione enter para continuar ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                        case 3:
                                    obj.Depositos();
                                    Console.WriteLine("Presione enter para continuar ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                        case 4:
                                    obj.MosMonto_Banco();
                                    Console.WriteLine("Presione enter para continuar ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                        case 5:
                                    break;

                            }


                        } while (q != 5);
                break;


                    
                case 5:
                    break;
            }


                Console.Clear();
            } while (y!=5);

      





        }
    }
}
