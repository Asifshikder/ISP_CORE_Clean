using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.BandwithResellerGivenItem.Command
{
    public static class Commands
    {
        public static class BandwithResellerGivenItem
        {
            public class Create : IRequest<BandwithResellerGivenItemCommandVM>
            {

                public string ItemName { get; set; }
                public string MeasureUnit { get; set; }
                public string PerUnitCommonPrice { get; set; }
            }

            public class Update : IRequest<BandwithResellerGivenItemCommandVM>
            {
                public int Id { get; set; }
                public string ItemName { get; set; }
                public string MeasureUnit { get; set; }
                public string PerUnitCommonPrice { get; set; }
            }

            public class MarkAsDelete : IRequest<BandwithResellerGivenItemCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
