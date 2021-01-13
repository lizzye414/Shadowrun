using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowrun3
{
    public class EnemyMatrixProgram
    {
        public int EnemyMatrixProgramId { get; set; }
        public int EnemyMatrixProgramRank { get; set; }

        //Foreign keys
        public virtual MatrixProgram MatrixProgram { get; set; }
        public virtual EnemyType EnemyType { get; set; }

    }
}
