import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';



platformBrowserDynamic().bootstrapModule(AppModule).catch(err => console.error(err));

  //https://www.flaticon.com/icon-fonts-most-downloaded