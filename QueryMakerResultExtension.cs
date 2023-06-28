using Microsoft.EntityFrameworkCore;

namespace QueryMakerLibrary.GetDataAsync;


/// <summary>
/// Static class which adds <see cref="GetDataAsync{T}(QueryMakerResult{T}, CancellationToken)" /> extension method for instances of <see cref="QueryMakerResult{T}" /> 
/// </summary>
public static class QueryMakerResultExtension
{
	/// <summary>
	/// Extension method which adds <see cref="GetDataAsync{T}(QueryMakerResult{T}, CancellationToken)" /> to instances of <see cref="QueryMakerResult{T}" />
	/// </summary>
	/// <param name="queryMakerResult">
	/// This instance of <see cref="QueryMakerResult{T}" /> which contains the queries to execute on provider.
	/// </param>
	/// <param name="cancellationToken">
	/// A <see cref="CancellationToken" /> to observe while waiting for the task to complete.
	/// </param>
	/// <typeparam name="T">The type of the elements of source.</typeparam>
	/// <returns>
	/// A task that represents the asynchronous operation. The task result contains a <see cref="QueryMakerData{T}" /> with array of items and count of unpaginated items obtained after executing queries on provider.
	/// </returns>
	/// <exception cref="OperationCanceledException">If the <paramref name="cancellationToken" /> is canceled.</exception>
	public static async Task<QueryMakerData<T>> GetDataAsync<T>(this QueryMakerResult<T> queryMakerResult,
		CancellationToken cancellationToken = default)
	{
		return new (await queryMakerResult.PaginatedQuery.ToArrayAsync(cancellationToken),
			await queryMakerResult.UnpaginatedQuery.CountAsync(cancellationToken));
	}
}
