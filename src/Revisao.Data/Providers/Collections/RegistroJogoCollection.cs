using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Providers.Collections
{
    [BsonCollection("RegistroJogo")]
    public class RegistroJogoCollection : Document
    {
        #region 2 - Propriedades
        public int primeiroNumero { get; set; }
        public int segundoNumero { get;  set; }
        public int terceiroNumero { get;  set; }
        public int quartoNumero { get;  set; }
        public int quintoNumero { get;  set; }
        public int sextoNumero { get;  set; }
        #endregion

    }
}
