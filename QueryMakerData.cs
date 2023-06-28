namespace QueryMakerLibrary.GetDataAsync;

/// <summary>
/// Object used for returning resulting data when calling <see cref="QueryMakerResultExtension.GetDataAsync{T}(QueryMakerResult{T}, CancellationToken)" />.
/// </summary>
public readonly struct QueryMakerData<T>
{
	internal QueryMakerData(T[] items, int totalAmmount)
	{
		Items = items;
		TotalAmmount = totalAmmount;
	}

	/// <summary>
	/// Resulting elements after pagination.
	/// </summary>
	public readonly T[] Items { get; private init; }

	/// <summary>
	/// Total ammount of elements withouth pagination.
	/// </summary>
	public readonly int TotalAmmount { get; private init; }
}