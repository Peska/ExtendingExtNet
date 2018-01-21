Ext.define('PD.Controls.Pesel', {

    extend: 'Ext.form.field.Text',
    alias: 'pesel',
    template: '<span class="{0}">{1}</span>',
    useHiddenField: true,

    setAutoFilledValue: function (value) {
        this.autoFilledValue = value;
        this.hiddenField.dom.value = this.getHiddenState();
    },

     // value to jest text z ext:TextField. Nie potrzebuję tej wartości tutaj.
    getHiddenState: function (value) {
        return JSON.stringify({
            autoFilledValue: this.autoFilledValue
        });
    }
});