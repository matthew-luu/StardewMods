using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Inventories;
using StardewValley.Mods;

namespace Pathoschild.Stardew.Automate.Framework.Storage;

/// <summary>An Automate container backed by a Network Chest inventory.</summary>
internal class NetworkChestContainer : IContainer
{
    private readonly string NetworkId;

    public GameLocation Location { get; }

    public NetworkChestContainer(string networkId)
    {
        this.NetworkId = networkId;
    }

    /// <summary>The shared inventory for this network.</summary>
    public Inventory Inventory =>
        NetworkChest.GetInventory(this.NetworkId);

    public string TypeId => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    public ModDataDictionary ModData => throw new NotImplementedException();

    public bool IsJunimoChest => throw new NotImplementedException();

    public bool IsLocked => throw new NotImplementedException();

    public object InventoryReferenceId => throw new NotImplementedException();

    IInventory IContainer.Inventory => this.Inventory;

    public Rectangle TileArea => throw new NotImplementedException();

    public ITrackedStack? Get(Func<Item, bool> predicate, int count)
    {
        throw new NotImplementedException();
    }

    public void Store(ITrackedStack stack)
    {
        throw new NotImplementedException();
    }

    public int GetFilled()
    {
        throw new NotImplementedException();
    }

    public int GetCapacity()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<ITrackedStack> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
