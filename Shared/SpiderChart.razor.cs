using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Smart.Blazor;

namespace Galaxy
{
    public partial class SpiderChart : Smart.Blazor.Chart 
    {
  
       
        
        [Parameter]
        public Smart.Blazor.Chart SpiderChartRef { get; set; }

        
        [Parameter]
        public List<Dictionary<string, object>> InterestsData { get; set; }

    
        
        [Parameter]
        public Smart.Blazor.ChartXAxis InterestsXAxis { get; set; }

        
        [Parameter]
        public List<ChartSeriesGroup> InterestsSeriesGroups { get; set; }

        private void onChartReady(Chart chart)
        {
            chart.Refresh();
        }
    }
}