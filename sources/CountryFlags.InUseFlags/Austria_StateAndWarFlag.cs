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

public class Austria_StateAndWarFlag : CountryFlag
{
    public Austria_StateAndWarFlag()
    {
        Country = Countries.Austria;

        Id = "StateAndWar";
        Names = new List<FlagName>
        {
            new()
            {
                EnglishTranslation = "War Flag"
            }
        };
        Description = "A horizontal triband of red (top and bottom) and white defaced with the Coat of arms of Austria at its centre.";
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign;
    }
}