namespace DuckDB
{
    /// <summary>
    /// Just a placeholder
    /// </summary>
    public class PartitioningPolicy
    {
        public string PartitionKeyName { get; set; }

        public PartitionKind Kind { get; set; }
    }

    public enum PartitionKind
    {
        Hash, Range, Spatial
    }
}