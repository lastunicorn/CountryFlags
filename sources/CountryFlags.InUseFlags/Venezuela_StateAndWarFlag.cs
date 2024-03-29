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

public class Venezuela_StateAndWarFlag : CountryFlag
{
    public Venezuela_StateAndWarFlag()
    {
        Country = Countries.Venezuela;

        Id = "StateAndWar";
        Names = new List<FlagName>
        {
            "State and War"
        };
        Description = "A horizontal tricolour of yellow, blue and red with the National Coat of Arms on the upper hoist-side of the yellow band and an arc of eight white five-pointed stars centred on the blue band.";
        StartDate = new FlagDate(2006, 03, 12);
        DesignedBy = "Francisco de Miranda";
        Usage = FlagUsage.StateFlag | FlagUsage.WarFlag | FlagUsage.StateEnsign | FlagUsage.WarEnsign;
    }
}