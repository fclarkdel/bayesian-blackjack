using BayesianBlackjack.Application.Actors.Interfaces;
using BayesianBlackjack.Application.Objects;

namespace BayesianBlackjack.Interface.Services;

public class PlayerService : IPlayerService
{
	public event Action? OnChange;

	public IPlayer Player { get; set; }

	public PlayerService(IPlayer player)
	{
		Player = player;
	}

	public void AddCard(Card card)
	{
		Player.Hand.Add(card);
		OnChange?.Invoke();
	}

	public void RemoveCard(Card card)
	{
		Player.Hand.Remove(card);
		OnChange?.Invoke();
	}
}
