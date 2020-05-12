using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    //Adam's notes
    //Steps:
    //1. Create a class that extends PointsAggregator
    //2. Override the FilterMeasurements method to filter for measurements with both an X and Y of greater than 2
    //3. Override the Aggregate method to return the Sum of all Xs and Ys into a new Measurement of X (sum of Xs) and Y (sum of Ys)
    
    //Benefits
    //Very quick and easy to implement
    //Less code
    //No duplication
    
    //Drawbacks
    //High coupling between this class and the base classes. If the base classes change, this class could break.
    
    
    
    /// <summary>
    /// Should filter out measurements with an X or Y that are less than or equal to 2
    /// You'll need to inherit and override methods from other classes in the inheritance folder
    /// </summary>
    public class HighPassSummingAggregator : SummingAggregator
    {
        public HighPassSummingAggregator(IEnumerable<Measurement> measurements) : base(measurements)
        {
        }
        
        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(measurement => measurement.X > 2 && measurement.Y > 2);
        }
    }    
}