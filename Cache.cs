namespace CalculationSimulation
{
    /// <summary>
    /// This class acts as a cache of already calculated results
    /// </summary>
    public class Cache
    {
        #region Instance fields
        private int[,] cacheValues;
        #endregion
        public const int DimensionX = 10;
        public const int DimensionY = 10;
        public const int NoValue = -1;

        #region Constructor
        public Cache()
        {
            // Create a 5x5 cache of results
            cacheValues = new int[DimensionX, DimensionY];

            for (int x = 0; x < DimensionX; x++)
            {
                for (int y = 0; y < DimensionY; y++)
                {
                    cacheValues[x, y] = NoValue; // -1 means "no result stored"
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Look up the value stored in cell [x,y]
        /// </summary>
        public int Lookup(int x, int y)
        {
            return cacheValues[x, y];
        }

        /// <summary>
        /// Stores the given value in cell [x,y]
        /// </summary>
        public void Insert(int x, int y, int value)
        {
            cacheValues[x, y] = value;
        } 
        #endregion
    }
}
