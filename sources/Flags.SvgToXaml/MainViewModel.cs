// Country Flags
// Copyright (C) 2022 Dust in the Wind
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

using System;
using System.IO;
using System.Windows.Controls;
using System.Xml;
using DustInTheWind.Flags.SvgToXaml.ConversionExtensions;
using DustInTheWind.Flags.SvgToXaml.Svg;

namespace Flags.SvgToXaml;

public class MainViewModel : ViewModelBase
{
    private string? svgText;
    private string? xamlText;

    public string? SvgText
    {
        get => svgText;
        set
        {
            svgText = value;
            OnPropertyChanged();

            TransformSvgToXaml();
        }
    }

    public string? XamlText
    {
        get => xamlText;
        set
        {
            xamlText = value;
            OnPropertyChanged();
        }
    }

    private void TransformSvgToXaml()
    {
        try
        {
            if (string.IsNullOrEmpty(svgText))
            {
                XamlText = null;
                return;
            }

            SvgDocument svgDocument = SvgDocument.Parse(svgText);
            Canvas? canvas = svgDocument.Svg.ToXaml();

            XamlText = Serialize(canvas);
        }
        catch (Exception ex)
        {
            XamlText = ex.ToString();
        }
    }

    private static string Serialize(Canvas? canvas)
    {
        if (canvas == null)
            return string.Empty;

        using MemoryStream ms = new();
        XmlWriterSettings xmlWriterSettings = new()
        {
            Indent = true,
            NewLineOnAttributes = true
        };
        XmlWriter xmlWriter = XmlWriter.Create(ms, xmlWriterSettings);

        System.Windows.Markup.XamlWriter.Save(canvas, xmlWriter);

        ms.Position = 0;
        using StreamReader sr = new(ms);

        return sr.ReadToEnd();
    }
}