<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619928/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4270)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/WindowsApplication3/MainForm.cs) (VB: [MainForm.vb](./VB/WindowsApplication3/MainForm.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
* [CheckEditViewInfoDescendant.cs](./CS/WindowsApplication3/ToggleSwitch/CheckEditViewInfoDescendant.cs) (VB: [CheckEditViewInfoDescendant.vb](./VB/WindowsApplication3/ToggleSwitch/CheckEditViewInfoDescendant.vb))
* [RepositoryItemToggleSwitch.cs](./CS/WindowsApplication3/ToggleSwitch/RepositoryItemToggleSwitch.cs) (VB: [RepositoryItemToggleSwitch.vb](./VB/WindowsApplication3/ToggleSwitch/RepositoryItemToggleSwitch.vb))
* [ToggleSwitch.cs](./CS/WindowsApplication3/ToggleSwitch/ToggleSwitch.cs) (VB: [ToggleSwitch.vb](./VB/WindowsApplication3/ToggleSwitch/ToggleSwitch.vb))
<!-- default file list end -->
# How to create a ToggleSwitch editor


<p><strong>T</strong><strong>his </strong><strong>control </strong><strong>is available out-of-the-box starting from version 1</strong><strong>3</strong><strong>.</strong><strong>1</strong><strong>. </strong></p><br />
<p><strong>For earlier versions:</strong></p><p></p><p>This examples illustrates how to create a custom CheckEdit, so it functions as ToggleSwitch. Our custom ToggleSwitch editor contains the following properties: <br />
<strong>OnImage</strong> and <strong>OffImage</strong> to determine images for the On and Off states;<br />
<strong>OnText </strong>and <strong>OffText</strong> to determine a text that will be shown along with an image based upon a current state;<br />
<strong>IsOn</strong> to determine whether or not the current state is On.</p><p>In addition, we have implemented the <strong>ToggleSwitch.Toggled</strong> event that is raised when a state is changed. </p>

<br/>


