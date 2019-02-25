import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

// Components
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { IndexComponent } from './index/index.component';

// Services
import {AppRouterModule} from './app-router.module';


// Material Design
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {
  MatButtonModule, MatCardModule, MatDialogModule, MatInputModule, MatListModule, MatSelectModule, MatSortModule,
  MatTableModule,
  MatToolbarModule, MatDatepickerModule, MatNativeDateModule
} from '@angular/material';

import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';

// Forms
import {ReactiveFormsModule} from '@angular/forms';
import {FormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    IndexComponent,
    RegisterComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRouterModule, HttpClientModule,
    // Material
    BrowserAnimationsModule, MatSortModule, MatButtonModule, MatTableModule, MatListModule,
    ReactiveFormsModule, FormsModule, MatInputModule, MatCardModule, MatSelectModule, MatToolbarModule, MatDialogModule,
    MatNativeDateModule, MatDatepickerModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
