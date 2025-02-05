﻿using System.Drawing;
using Onitama.Core.MoveCardAggregate.Contracts;
using Onitama.Core.PlayerAggregate.Contracts;
using Onitama.Core.SchoolAggregate;
using Onitama.Core.SchoolAggregate.Contracts;
using Onitama.Core.Util;

namespace Onitama.Core.PlayerAggregate;

/// <inheritdoc cref="IPlayer"/>
internal class PlayerBase : IPlayer
{
    public Guid Id { get; }
    public string Name { get; }
    public Color Color { get; }

    public Direction Direction { get; }

    public ISchool School { get; }

    public IList<IMoveCard> MoveCards { get; }

    protected PlayerBase(Guid id, string name, Color color, Direction direction, ISchool school, IList<IMoveCard> moveCards)
    {
        Id = id;
        Name = name;
        Color = color;
        Direction = direction;
        School = school;
        MoveCards = moveCards;
    }
    /// <summary>
    /// Creates a player that is a copy of an other player.
    /// </summary>
    /// <remarks>
    /// This is an EXTRA. Not needed to implement the minimal requirements.
    /// To make the mini-max algorithm for an AI game play strategy work, this constructor should be implemented.
    /// </remarks>
    public PlayerBase(IPlayer otherPlayer)
    {
        Id = otherPlayer.Id;
        Name = otherPlayer.Name;
        Color = otherPlayer.Color;
        Direction = otherPlayer.Direction;
    }
}