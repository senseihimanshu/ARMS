import { UrltoFile } from './../../../utils/urlToFile';
import { Component, Input } from '@angular/core';
import { BufferToPdf } from 'src/app/utils/bufferToPdf';
@Component({
  selector: 'app-candidate-description',
  templateUrl: 'candidate-description.component.html',
  providers: [UrltoFile]
})
export class CandidateDescriptionComponent {
  @Input()
  data: any;

  constructor(private bufferToPdf: BufferToPdf) { }

  openResume() {
    this.data.candidate.resume = this.bufferToPdf.bufferToPdf(this.data.candidate.resume);

    let newPdfWindow = window.open("", "Print");

    let iframe = `<\iframe width='100%' height='100%' src="${this.data.candidate.resume}"><\/iframe>`;

    newPdfWindow.document.write(iframe);
  }
}
