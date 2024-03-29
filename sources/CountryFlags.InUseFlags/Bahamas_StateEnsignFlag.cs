﻿// Country Flags
// Copyright (C) 2022-2024 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace DustInTheWind.CountryFlags.InUseFlags;

public class Bahamas_StateEnsignFlag : CountryFlag
{
    public Bahamas_StateEnsignFlag()
    {
        Country = Countries.Bahamas;

        Id = "StateEnsign";
        Names = new List<FlagName>
        {
            new ()
            {
                EnglishTranslation = "Flag of the Auxiliary Fleet of the Navy"
            }
        };
        Description = "A blue cross on a white field, the national flag in the canton.";
        Usage = FlagUsage.StateEnsign;
    }
}