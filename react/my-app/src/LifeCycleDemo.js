import React from 'react';

class LifeCycleDemo extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {
        return <h1> Helllo this is lifecycle component</h1>;

    }

    componentDidMount() {
        
    }
}



export default LifeCycleDemo;