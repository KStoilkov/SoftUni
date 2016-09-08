package com.kstoilkov.android_course_homework_1;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends Activity implements View.OnClickListener {

    private int buttonOnePressedTimes;
    private int buttonTwoPressedTimes;

    private Button button2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        buttonOnePressedTimes = 0;
        buttonTwoPressedTimes = 0;

        setContentView(R.layout.activity_main);

        button2 = (Button) findViewById(R.id.btn2);
        button2.setOnClickListener(this);
    }

    public void increaseNum(View view){
        if(view.getId() == R.id.btn1){
            buttonOnePressedTimes++;
            ((Button)view).setText(String.valueOf(buttonOnePressedTimes));
        }
    }

    @Override
    public void onClick(View view) {
        if (view.getId() == R.id.btn2){
            buttonTwoPressedTimes++;
            button2.setText(String.valueOf(buttonTwoPressedTimes));
        }
    }
}
