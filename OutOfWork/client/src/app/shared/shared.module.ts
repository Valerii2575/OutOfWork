import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDividerModule } from '@angular/material/divider';
import { MatToolbarModule } from '@angular/material/toolbar'; 
import { MatIconModule } from '@angular/material/icon' ;
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatListModule} from '@angular/material/list';
import { MatCardModule } from '@angular/material/card'


import { FooterComponent } from './components/footer/footer.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { HeaderComponent } from './components/header/header.component';
import { RouterModule } from '@angular/router';
import { AreaComponent } from './widgets/area/area.component';
import { CardComponent } from './widgets/card/card.component';



@NgModule({
  declarations: [
    FooterComponent,
    SidebarComponent,
    HeaderComponent,
    FooterComponent,
    AreaComponent,
    CardComponent
  ],
  imports: [
    CommonModule,
    MatDividerModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatMenuModule,
    MatListModule,
    MatCardModule,
    RouterModule
  ],
  exports: [
    SidebarComponent,
    HeaderComponent,
    FooterComponent,
    AreaComponent,
    CardComponent
  ]
})
export class SharedModule { }
