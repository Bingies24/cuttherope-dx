namespace CutTheRopeDX.GameMain
{
    /// <summary>
    /// Decides whether a completed level's result should be written to saved progress.
    /// </summary>
    internal static class LevelProgressPersistence
    {
        /// <summary>
        /// Determines whether a new score should replace the stored one.
        /// </summary>
        /// <param name="customLevelActive">Whether this process is running an externally supplied level.</param>
        /// <param name="newValue">Score achieved in the completed level.</param>
        /// <param name="storedValue">Score currently saved for the level.</param>
        /// <returns><see langword="true"/> when the value should be persisted; otherwise <see langword="false"/>.</returns>
        public static bool ShouldPersistScore(bool customLevelActive, int newValue, int storedValue)
        {
            return !customLevelActive && newValue > storedValue;
        }

        /// <summary>
        /// Determines whether a new star count should replace the stored one.
        /// </summary>
        /// <param name="customLevelActive">Whether this process is running an externally supplied level.</param>
        /// <param name="newValue">Star count achieved in the completed level.</param>
        /// <param name="storedValue">Star count currently saved for the level.</param>
        /// <param name="levelStars">Maximum stars you can collect in the level.</param>
        /// <returns><see langword="true"/> when the value should be persisted; otherwise <see langword="false"/>.</returns>
        public static bool ShouldPersistStars(bool customLevelActive, int newValue, int storedValue, int levelStars)
        {
            return !customLevelActive && (newValue > storedValue || newValue > levelStars);
        }
    }
}
