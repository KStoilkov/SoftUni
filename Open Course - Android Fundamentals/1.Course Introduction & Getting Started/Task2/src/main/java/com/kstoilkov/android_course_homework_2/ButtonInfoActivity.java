package com.kstoilkov.android_course_homework_2;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class ButtonInfoActivity extends Activity {

    private Intent derivedIntent;

    private TextView idHolder;
    private TextView textHolder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_button_info);

        idHolder = (TextView) this.findViewById(R.id.idHolder);
        textHolder = (TextView) this.findViewById(R.id.textHolder);

        derivedIntent = getIntent();

        if (derivedIntent != null){
            idHolder.setText("Id : " + String.valueOf(derivedIntent.getIntExtra("id", Integer.MIN_VALUE)));
            textHolder.setText("Name : " + derivedIntent.getStringExtra("text"));
        }
    }
}
