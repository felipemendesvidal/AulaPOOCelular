namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        /// <summary>
        ///     converte de string para bool
        /// </summary>
        /// <param name="condicao"></param>
        /// <returns>true or false</returns>
         public bool Ligar(string condicao){
           switch(condicao){
                case "s":
                    ligado = true;
                break;
                case "n":
                    ligado = false;
                break;
                default:
                break;
           }
            return ligado;
        }

       

    }
}