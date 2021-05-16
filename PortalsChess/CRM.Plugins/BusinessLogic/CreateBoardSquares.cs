using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using System.ServiceModel;

namespace PortalsChess
{
    class CreateBoardSquares
    {
        public static void createBoard(IOrganizationService service, pc_Board target)
        {
            char[] alph = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    pc_Square square = new pc_Square();
                    

                }
            }
        }
    }
}
