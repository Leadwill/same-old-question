import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { GroupComponent } from "../group/group.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, GroupComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'soqs';
}
