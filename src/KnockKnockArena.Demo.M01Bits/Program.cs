using KnockKnockArena.Shared.Protocol.Udp;

// Console.WriteLine(WeaponBits.HashWeapon(WeaponBits.StartingWeapons, WeaponId.Glock));
// Console.WriteLine(WeaponBits.HashWeapon(WeaponBits.StartingWeapons, WeaponId.Ak47));

// Console.WriteLine(WeaponBits.ToBinaryString(WeaponBits.AddWeapon(WeaponBits.StartingWeapons, WeaponId.Ak47)));




// byte owned = WeaponBits.StartingWeapons;

// Show("Spawning (Punch + Glock)", owned);

// owned = WeaponBits.AddWeapon(owned, WeaponId.Ak47);

// Show("Picked up Ak47", owned);

// owned = WeaponBits.AddWeapon(owned, WeaponId.RocketLauncher);

// Show("Picked up RocketLauncher!", owned);

// owned = WeaponBits.AddWeapon(owned, WeaponId.Ak47);

// Show("Picked up Ak47", owned);

// owned = WeaponBits.RemoveWeapon(owned, WeaponId.RocketLauncher);

// Show("Dropped RocketLauncher!", owned);

// owned = WeaponBits.StartingWeapons;

// Show("Respawned with starting weapons", owned);

// void Show(string label, byte value)
// {
//     List<String> names = new List<String>();

//     foreach (WeaponId w in Enum.GetValues(typeof(WeaponId)))
//     if(WeaponBits.HashWeapon(value, w)) names.Add(w.ToString());

//     Console.WriteLine($"{label, -30} {WeaponBits.ToBinaryString(value)}  " + $"0x{value:X2} {value,3} [{string.Join(", ", names)}]");
// }





// MoventBits keys = MoventBits.W | MoventBits.D | MoventBits.Sprint;

// Console.WriteLine($"Keys held: W + D + shift -> Movement byte {WeaponBits.ToBinaryString((byte)keys)} = 0x {(byte)keys:X2} = {(byte)keys}");

// Console.WriteLine($"   [Flags] prints it as \"{keys}\"; is sprint set? {(keys & MoventBits.Sprint) != 0}; is S set? {(keys & MoventBits.S) != 0}");

// MoventBits released = keys & ~MoventBits.Sprint;

// Console.WriteLine($"  release Shift (AND NOT Sprint): {WeaponBits.ToBinaryString((byte)released)} = \"{released}\"");

// ButtonBits button = (ButtonBits)0b0000_0011;

// Console.WriteLine($"  a button byte of 00000011 means \"{button}\" - both travel in the 22-byte input packet (M06)");




Console.WriteLine("Same eight bits, two types");

byte allOnes = 0b1111_1111;
sbyte assSigned = unchecked((sbyte)allOnes);

Console.WriteLine($" {WeaponBits.ToBinaryString(allOnes)} -> byte {allOnes}, sbyte{assSigned}");