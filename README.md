WPF Loading Animitions
======================
![Demo](./WpfLoadingAnimations.gif)

## Usage
- Include Namespace
```xml
<Window ...
        xmlns:mp="http://schemas.mpcoding.com/mpcoding/wpf/loadinganimation">
```
- Add Loading indicator and select mode
```xml
<mp:DonutSpinner Width="200" Height="200" SpinnerColor="LightGreen" Duration="0:0:1.0"/>

<mp:ArcSpinner Cap="Round" Diameter="200" Thickness="10" Color="Red" Duration="0:0:1.0" />

<mp:CogwheelSpinner Content="Loading..." Foreground="Chocolate" Color="#e04f5f" Duration="0:0:1.0" />

<mp:DotsRingSpinner Width="150" Height="150" Color="#05c3ee" Duration="0:0:2.0" />

<mp:ThreeDotsAnimation Width="100" Height="100" Color="White" Duration="0:0:1.0" />

<mp:WaveAnimation Width="100" Height="100" Color="DarkOrange" Duration="0:0:2.0" />
```