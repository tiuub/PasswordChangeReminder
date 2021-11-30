# PasswordChangeReminder

PasswordChangeReminder is a plugin for [KeePass](http://keepass.info). It will remind you to change choosen passwords repetitive after a specific timespan. For example every 90 or 120 days.

[![Latest Release](https://img.shields.io/github/v/release/tiuub/PasswordChangeReminder)](https://github.com/tiuub/PasswordChangeReminder/releases/latest)
[![GitHub All Releases](https://img.shields.io/github/downloads/tiuub/PasswordChangeReminder/total)](https://github.com/tiuub/PasswordChangeReminder/releases/latest)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=5F5QB7744AD5G&source=url)


## Installation

- Download the latest release [here](https://github.com/tiuub/PasswordChangeReminder/releases/latest)
- Copy the PasswordChangeReminder.plgx in the KeePass plugins directory and restart the application.

#### Chocolatey 📦 
Or you can [use Chocolatey to install](https://community.chocolatey.org/packages/keepass-plugin-passwordchangereminder#install) it in a more automated manner:

```
choco install keepass-plugin-passwordchangereminder
```

To [upgrade KeePass Plugin PasswordChangeReminder](https://community.chocolatey.org/packages/keepass-plugin-passwordchangereminder#upgrade) to the [latest release version](https://community.chocolatey.org/packages/keepass-plugin-passwordchangereminder#versionhistory) for enjoying the newest features, run the following command from the command line or from PowerShell:

```
choco upgrade keepass-plugin-passwordchangereminder
```

## Usage

To set up a reminder, you have to activate the reminder in the "Advanced"-Tab of a entry. 

For this, you have to choose the entry, you want to get remind for:
- Advanced -> Check the Box -> Choose the reminder interval

![Configuration Example](Screenshots/screenshot-2.PNG)


After you the configuration, you can see a overview by clicking 
- Tools -> Password Change Reminder. 

Otherwise you can activate the function, "Automatically remind on startup", which will remind you for changing matured passwords on startup, if there is one.

![Overview Example](Screenshots/screenshot-1.PNG)


Also you can activate the column, to get a great overview of the remaining timings.

![Column Example](Screenshots/screenshot-3.PNG)



## Settings

You can change some settings in the settings form.
Therefore navigate to 
- Tools -> Password Change Reminder -> Settings.

![Settings Example](Screenshots/screenshot-4.PNG)



## Download

You can download the .plgx file [here](https://github.com/tiuub/PasswordChangeReminder/releases/latest).



## License

[![GitHub](https://img.shields.io/github/license/tiuub/PasswordChangeReminder)](https://github.com/tiuub/PasswordChangeReminder/blob/master/LICENSE)
