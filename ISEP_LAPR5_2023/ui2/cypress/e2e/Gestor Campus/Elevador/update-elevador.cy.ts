import "../../../support/commands";
describe('Update tests for Elevador', () => {
	beforeEach(() => {
	  cy.login()
	});
    
	it('should update elevador', () => {
		cy.get(':nth-child(2) > .mdc-button__label').click();
		cy.get('#mat-menu-panel-0 > .mat-mdc-menu-content > :nth-child(5)').click();
		cy.get('#mat-menu-panel-4 > .mat-mdc-menu-content > :nth-child(3) > .mat-mdc-menu-item-text').click();
		cy.wait(2000);
cy.get('#mat-select-value-1 > .mat-mdc-select-placeholder').click();
cy.get('#mat-option-14').click();
cy.get(':nth-child(2) > :nth-child(2) > .ng-untouched').clear();
cy.get(':nth-child(2) > :nth-child(2) > .ng-untouched').type('fica igual');
cy.get(':nth-child(2) > :nth-child(2) > .ng-untouched').clear();
cy.get(':nth-child(2) > :nth-child(2) > .ng-untouched').type('uma outra');
cy.get(':nth-child(3) > :nth-child(2) > .ng-untouched').clear();
cy.get(':nth-child(3) > :nth-child(2) > .ng-untouched').type('32019');
cy.get(':nth-child(4) > :nth-child(2) > .ng-untouched').clear();
cy.get(':nth-child(4) > :nth-child(2) > .ng-untouched').type('redbull winter');
cy.get(':nth-child(5) > :nth-child(2) > .ng-untouched').click();
cy.get(':nth-child(2) > .ng-untouched').clear();
cy.get(':nth-child(2) > .ng-untouched').type('redbull');
cy.get('#mat-select-value-3 > .mat-mdc-select-placeholder').click();
cy.get('#mat-option-5').click();
cy.get(':nth-child(6) > button').click();
cy.get('.mat-mdc-select-placeholder').click();
cy.get('.mdc-list-item__primary-text').click();
cy.get('.cdk-overlay-backdrop').click();
cy.get('.box > :nth-child(2) > :nth-child(1)').click();
cy.on("window:alert", (text) =>  {
	expect(text).to.contain("Success elevador update!")
}) 
	});
	
  });