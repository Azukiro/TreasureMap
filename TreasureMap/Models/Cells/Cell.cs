﻿using TreasureMap.Validators.Attribute;

namespace TreasureMap.Models.Cells;

/// <summary>
///     Base class for a cell in the map.
/// </summary>
public abstract class Cell
{
    /// <summary>
    ///     Constructor of the cell.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    protected Cell(int x, int y)
    {
        Position = new Position(x, y);
    }

    /// <summary>
    ///     Position of the cell in the map.
    /// </summary>
    [PositionInMap]
    [UniquePositionInMap]
    public Position Position { get; }

    /// <summary>
    ///     Determines if an adventurer can move to this cell.
    /// </summary>
    /// <returns></returns>
    public virtual bool CanMoveTo()
    {
        return true;
    }

    /// <summary>
    ///     Moves an adventurer to this cell.
    /// </summary>
    /// <param name="adventurer"></param>
    public virtual void MoveTo(Adventurer adventurer)
    {
    }
}