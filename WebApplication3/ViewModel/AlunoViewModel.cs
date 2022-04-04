namespace WebApplication3.ViewModel
{
    public class AlunoViewModel
    {
        public string Nome { get; set; }

        public string   Matricula { get; set; }

        public string Turno { get; set; }

       

        //metodo que valida o nome
        public bool ValidaNome()
        {
            //validando se é vazia ou nula
            var nome = this.Nome;

            if (string.IsNullOrEmpty(nome)  )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //metodo que valida a matricula
        public bool ValidaMat()
        {
            var mat = this.Matricula;

            if (string.IsNullOrEmpty(mat) && mat.Length < 15 && mat.Length > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //metodo que valida o turno
        public bool ValidaTurno()
        {
            var turno = this.Turno;

            if (string.IsNullOrEmpty(turno))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
