namespace MoiteRecepti.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MoiteRecepti.Services.Data.Models;
    using MoiteRecepti.Web.ViewModels.Home;

    public interface IGetCountService
    {
        // 1.Use ViewModels
        // 2.Create Dto ->viewmodel
        // 3.tuples
        CountsDto GetCounts();
    }
}
