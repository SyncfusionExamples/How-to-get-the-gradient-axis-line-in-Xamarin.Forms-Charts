# How-to-get-the-gradient-axis-line-in-Xamarin.Forms-Charts
This article explains how to get the gradient color axis line in Xamarin.Forms Charts as shown in below

 ![](output.png)

In order to define the axis range with various color combination as updated in above then it has been achieved by using any of the following ways.
# Using StripLines
Using the [NumericalStripLine](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.NumericalStripLine.html) in Y-Axis line with varying the [SegmentStart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartStripLine.html#Syncfusion_SfChart_XForms_ChartStripLine_SegmentStart) and [SegmentEnd](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartStripLine.html#Syncfusion_SfChart_XForms_ChartStripLine_SegmentEnd), it is possible to achieve as per in below 

[XAML]

```
…
  <syncfusion:SfChart.PrimaryAxis>
                <syncfusion:NumericalAxis x:Name="primaryAxis" Minimum="0" Interval="50" Maximum="300"  >
                    <syncfusion:NumericalAxis.StripLines>
                        <syncfusion:NumericalStripLine FillColor="#f70a1d" 
                                                      Width="3" 
                                                      IsSegmented="True"
                                                      SegmentStart="0" 
                                                      SegmentEnd="200" 
                                                      SegmentAxisName="secondaryAxis"
                                                      Start="{Binding Minimum, Source={x:Reference primaryAxis}}"/>

                        <syncfusion:NumericalStripLine FillColor="#f0e351" 
                                                      Width="3" 
                                                      IsSegmented="True"
                                                      SegmentStart="200" 
                                                      SegmentEnd="400" 
                                                      SegmentAxisName="secondaryAxis"
                                                      Start="{Binding Minimum, Source={x:Reference primaryAxis}}"/>

                        <syncfusion:NumericalStripLine FillColor="#3ae84b" 
                                                      Width="3" 
                                                      IsSegmented="True"
                                                      SegmentStart="400" 
                                                      SegmentEnd="600" 
                                                      SegmentAxisName="secondaryAxis"
                                                      Start="{Binding Minimum, Source={x:Reference primaryAxis}}"/>
                    </syncfusion:NumericalAxis.StripLines>
                </syncfusion:NumericalAxis>
            </syncfusion:SfChart.PrimaryAxis>

            <syncfusion:SfChart.SecondaryAxis>
                <syncfusion:NumericalAxis x:Name="secondaryAxis" Minimum="0" Interval="200" Maximum="600" >
                </syncfusion:NumericalAxis>
            </syncfusion:SfChart.SecondaryAxis>
…
```
# Using LineSeries
Instead of using chart axis use [LineSeries](https://help.syncfusion.com/xamarin/charts/charttypes#line-chart) with [GradientColor](https://help.syncfusion.com/xamarin/charts/appearance#gradient-colors) support to draw straight line (Graduation scale color by split line).

[XAML]
```
…
<syncfusion:SfChart.Series>
                <syncfusion:LineSeries x:Name="gradientSeries" StrokeWidth="20" >
                    <syncfusion:LineSeries.ColorModel>
                        <syncfusion:ChartColorModel Palette="Custom">
                            <syncfusion:ChartColorModel.CustomGradientColors>
                                <syncfusion:ChartGradientColor StartPoint="0.5,0" EndPoint="0.5,1">
                                    <syncfusion:ChartGradientColor.GradientStops>
                                        <syncfusion:ChartGradientStop Color="Red" Offset= "0"/>
                                        <syncfusion:ChartGradientStop Color="Red" Offset= "1"/>
                                    </syncfusion:ChartGradientColor.GradientStops>
                                </syncfusion:ChartGradientColor>
                                <syncfusion:ChartGradientColor StartPoint="0.5,0" EndPoint="0.5,1">
                                    <syncfusion:ChartGradientColor.GradientStops>
                                        <syncfusion:ChartGradientStop Color="Green" Offset= "0"/>
                                        <syncfusion:ChartGradientStop Color="Green" Offset= "1"/>
                                    </syncfusion:ChartGradientColor.GradientStops>
                                </syncfusion:ChartGradientColor>
                                <syncfusion:ChartGradientColor StartPoint="0.5,0" EndPoint="0.5,1">
                                    <syncfusion:ChartGradientColor.GradientStops>
                                        <syncfusion:ChartGradientStop Color="Blue" Offset= "0"/>
                                        <syncfusion:ChartGradientStop Color="Blue" Offset= "1"/>
                                    </syncfusion:ChartGradientColor.GradientStops>
                                </syncfusion:ChartGradientColor>
                            </syncfusion:ChartColorModel.CustomGradientColors>
                        </syncfusion:ChartColorModel>
                    </syncfusion:LineSeries.ColorModel>
                </syncfusion:LineSeries>
…
```

# See also

[How to customize the axis label format based on the culture in Xamarin.Forms Chart (SfChart)](https://www.syncfusion.com/kb/11289/how-to-customize-the-axis-label-format-based-on-the-culture-in-xamarin-forms-chart-sfchart)

[How to customize the axis labels](https://www.syncfusion.com/kb/5545/how-to-customize-the-axis-labels)

[How to plot date-time values in vertical axes](https://www.syncfusion.com/kb/8732/how-to-plot-date-time-values-in-vertical-axes)

[How to change the data point selection color](https://www.syncfusion.com/kb/4957/how-to-change-the-data-point-selection-color)
