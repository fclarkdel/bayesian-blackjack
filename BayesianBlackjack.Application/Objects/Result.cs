namespace BayesianBlackjack.Application.Objects;
/// <summary>
///		Represents the result of a set of trials for a probability distribution.
/// </summary>
public class Result
{
	public decimal ProbOfSuccesses { get; set; }
	public int NumOfSuccesses { get; }
	/// <summary>
	///		The probability of achieving a specific number of successes within
	///		a total amount of trials.
	/// </summary>
	/// <param name="probOfSuccesses">
	///		Probability of achieving a specific number of successes.
	/// </param>
	/// <param name="numOfSuccesses">
	///		Number of successes out of a total amount of trials.
	/// </param>
	public Result(decimal probOfSuccesses, int numOfSuccesses)
	{
		ProbOfSuccesses = probOfSuccesses;
		NumOfSuccesses = numOfSuccesses;
	}
}
