using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Composition
{
    //Steps
    //1. Create a class the implements the IMeasurementFilter interface
    //2. Override the Filter method to filter for measurements with both an X and Y of greater than 2
    //3. Create a  class to hide the "composition" of strategies and filters (HighPassSummingAggregator)
    //4. Just pass instantiate this class, passing the measurements to the constructor to perform the summing and filtering operations.
    
    //Benefits
    //Low coupling between classes. Can delete AggregationStrategies without unintentionally breaking other classes
    
    //Drawbacks
    //Seems to be more code, especially if we hide the composition by creating a new Aggregator class.
    //If hide composition by creating a new aggregator class, there is a lot of duplication (HighPassSummingAggregator & Points Aggregator.
    //However if we don't hide the composition like this, we have trivial classes that do nothing to satisfy the argument requirements (EmptyFilter)
    
    //Discussion points
    //1. Which would I rather build on in the future?
    //        Composition - Would be too scared to modify base classes in case I break a child class
    //2. Which provides better reusability
    //        (composition) - These individual classes are not coupled to a base class.

    /// <summary>
    /// Should filter out measurements with an X or Y that are less than or equal to 2
    /// You'll need to implement IMeasureFilter to do the job
    /// </summary>
    /// 
    public class HighPassFilter : IMeasurementFilter
    {
        public IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(measurement => measurement.X > 2 && measurement.Y > 2);
        }
    }
}