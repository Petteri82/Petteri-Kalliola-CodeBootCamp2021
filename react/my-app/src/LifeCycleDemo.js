import React from 'react';

class LifeCycleDemo extends React.Component {
    constructor(props) {
        super(props);
        console.log("LifeCycleDemo.constructor");
    }

    componentDidMount() {
        console.log("In LifeCycleDemo.componentDidMount");
        this.state = {title: ""};

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => {
                console.log(json);
                this.setState({ title: json.title});
                console.log("Component state has been modified")
            });    
            console.log("Fetch call has been made");
    }
    render() {
        console.log("In lifecycleDemo.render");
            return (
            <div>
                <h1> Helllo this is lifecycle component</h1>;
                <p>Title: {this.state.title?}</p>
            </div>);
            }            

    

    }
}



export default LifeCycleDemo;