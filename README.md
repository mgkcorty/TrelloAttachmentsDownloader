# TrelloAttachmentsDownloader
.NET Core Tiny app for downloading all attachments from specific trello card.

## Usage:
1) Open trello card;
2) Click on "Share" button;
3) Select "Export JSON" and save file on your computer;
4) Open command line or terminal and call:

``` dotnet TrelloAttachmentsDownloader.dll exported_json_file.json ```

5) All attachements from card downloaded to "card_name" folder.
