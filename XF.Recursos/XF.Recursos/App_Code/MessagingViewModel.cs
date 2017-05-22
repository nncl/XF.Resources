using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.Recursos.App_Code
{
    public class MessagingViewModel
    {
        public object Parametro { get; set; }
        public enum Navegacao
        {
            Inserir,
            Alterar,
            Remover,
            Visualizar
        }
        public Navegacao TipoNavegacao { get; set; } = new Navegacao();
    }
}
