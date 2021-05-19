using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Client;

namespace PortalsChess
{
    class BoardSquaresBL
    {
        public void createBoardSquaresAndAssociate(IOrganizationService service, pc_Board target)
        {
            char[] alph = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            var squareReferences = new EntityReferenceCollection();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pc_Square square = new pc_Square
                    {
                        pc_name = alph[i] + (j + 1).ToString()
                    };

                    square.Id = service.Create(square);
                    squareReferences.Add(square.ToEntityReference());
                }
            }
            var relationship = new Relationship("pc_Square_GameID_pc_Board");
            service.Associate(target.LogicalName, target.Id, relationship, squareReferences);
        }

    }
}
